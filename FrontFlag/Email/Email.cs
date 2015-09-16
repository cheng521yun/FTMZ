using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace FrontFlag
{
    public class EMAIL
    {
        bool _bCheck = false;
        string _strSMTP = "" , _strUser = "" , _strPass = "";

        public void SetSMTP ( string strSMTP , string strUser , string strPass )
        {
            _bCheck = true;
            _strSMTP = strSMTP;
            _strUser = strUser;
            _strPass = strPass;
        }

        public void SetSMTP ( )
        {
            _bCheck = false;
            _strSMTP = "";
            _strUser = "";
            _strPass = "";
        }

        public bool SendHtmEmail ( string strFromAddress , string strToAddress , string strSubject , string strHtmBody )
        {
            try
            {
                //create the mail message
                MailMessage mail = new MailMessage ( );

                mail.From = new MailAddress ( strFromAddress );
                mail.To.Add ( strToAddress );
                mail.Subject = strSubject;
                mail.Body = strHtmBody;
                mail.BodyEncoding = System.Text.Encoding.GetEncoding ( "gb2312" );
                mail.IsBodyHtml = true;

                //set SMTP
                SmtpClient smtp = new SmtpClient ( _strSMTP );

                //to authenticate we set the username and password properites on the SmtpClient
                if ( _bCheck )
                    smtp.Credentials = new NetworkCredential ( _strUser , _strPass );

                smtp.Send ( mail );

                return true;
            }
            catch ( Exception e )
            {
                return false;
            }
        }
    }

}
