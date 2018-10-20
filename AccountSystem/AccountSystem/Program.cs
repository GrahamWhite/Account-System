using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Reflection;

namespace AccountSystem
{
    static class Program
    {
        private struct Account
        {
            public string firstName;
            public string middleName;
            public string lastName;
            public int accountNumber;
            public double balance;
            public AccountState accountState;
            public DateTime accountOpenDate;
            public int isSecure;

        }
        public enum AccountState
        {
            New = 0,
            Closed = 1,
            Active = 2,
            UnderAudit = 3,
            Overdraft = 4
        };

        public static void EncryptFile(string inputFile, string outputFile, string skey)
        {
            byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

            byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                using (FileStream fileStreamCrypt = new FileStream(outputFile, FileMode.Create))
                {
                    using (ICryptoTransform crypto = aes.CreateEncryptor(key, IV))
                    {
                        using (CryptoStream cs = new CryptoStream(fileStreamCrypt, crypto, CryptoStreamMode.Write))
                        {
                            using (FileStream fsin = new FileStream(inputFile, FileMode.Open))
                            {
                                int data;
                                while ((data = fsin.ReadByte()) != -1)
                                {
                                    cs.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void DecryptFile(string inputFile, string outputFile, string skey)
        {
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);
                byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                {
                    using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                    {
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                            {
                                int data;
                                while ((data = cs.ReadByte()) != -1)
                                {
                                    fsOut.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int CreateAccount(string f, string m, string l, int acctNumber, double bal)
        {
            Account account = new Account();
            FieldInfo[] fields = account.GetType().GetFields();
            FieldInfo[] items = account.GetType().GetFields();
                
            account.firstName = null;
            account.middleName = null;
            account.lastName = null;
            account.accountNumber = 0;
            account.balance = 0;
            account.accountState = AccountState.New;
            account.accountOpenDate = DateTime.Now.Date;
            account.isSecure = 0;

            account.firstName = f;
            account.middleName = m;
            account.lastName = l;
            account.accountNumber = acctNumber;
            account.accountState = AccountState.New;
            account.balance = bal;




            using (StreamWriter sw = new StreamWriter(string.Format("./accounts/{0}.acct", account.accountNumber)))
            {
                foreach(FieldInfo i in items)
                {
                    sw.WriteLine(i.Name + ": " + i.GetValue(account));
                }
            }

            return 0;

        }
        
        
       

       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }

       
    }
}
