using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using Chat.Helpers;
using Chat.Models;
using Chat.Packets;
using Chat.Workers;


namespace Chat.ViewModels
{
    public class MainWindowModel : BaseViewModel
    {
        TcpClient Client;
        NetworkStream Stream;
        public MainWindowModel()
        {
            try
            {
                Client = new TcpClient("127.0.0.1", 1024);
                Stream = Client.GetStream();
                CurrentLogin = "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Сервер недоступен, попробуйте зайти позже", "Ошибка сервера");
                Application.Current.Shutdown();
            }
            
        }

        public string CurrentLogin { get; set; }

        public RelayCommand RegistrationBtn
        {
            get
            {
                return new RelayCommand(
                    obj =>
                    {
                        var pwBox = obj as PasswordBox;

                        if (CurrentLogin.Length < 4 || pwBox.Password.Length < 4)
                        {
                            MessageBox.Show("Минимальное кол-во символов в логине и пароле 4", "Ошибка");
                            return;
                        }

                        var user = new User(){Login = CurrentLogin, Password = PasswordHash.CreateHash(pwBox.Password)};
                        
                        PacketSender.SendJsonString(Stream, "REGISTER::" + JsonWorker.UserToJson(user));

                        //РАБОТА С БД
                        /*using (var db = new BloggingContext())
                        {
                            var ExUser = db.Users
                                .FirstOrDefault(item => item.Login == CurrentLogin);

                            if (ExUser != null)
                            {
                                MessageBox.Show("Такой пользователь уже зарегистрирован", "Ошибка");
                                return;
                            }


                            var user = new User();
                            user.Login = CurrentLogin;
                            user.Password = PasswordHash.CreateHash(pwBox.Password);

                            db.Users.Add(user);
                            db.SaveChanges();
                        }*/
                    }
                );
            }
        }
        
        public RelayCommand SignInBtn
        {
            get
            {
                return new RelayCommand(
                    obj =>
                    {
                        var pwBox = obj as PasswordBox;

                        //РАБОТА С БД
                        /*using (var db = new BloggingContext())
                        {
                             var user = db.Users
                                .FirstOrDefault(item =>(item.Login == CurrentLogin));

                             if (user!=null && PasswordHash.ValidatePassword(pwBox.Password,user.Password))
                             {
                                 
                                 
                             }
                             else
                             {
                                 MessageBox.Show("Неверный логин или пароль!");
                             }
                        }*/

                    }
                );
            }
        }
        
        
        
    }
}