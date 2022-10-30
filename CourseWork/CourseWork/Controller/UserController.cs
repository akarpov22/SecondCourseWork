using System;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using CourseWork.Model.ApiModel;

namespace CourseWork
{
    class UserController
    {

        public static bool CheckPasswordLVL1(string passwordLVL1)
        {
            bool result = false;
            UserApi user = new UserApi();
            user.Login = "User";
            user.Hash = passwordLVL1;

            var request = WebRequest.Create(Load.Server + "/users/check");
            request.ContentType = "application/json";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                streamWriter.Write(JsonConvert.SerializeObject(user));

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                result = Convert.ToBoolean(reader.ReadToEnd());
            }

            return result;
        }

        public static bool CheckPasswordLVL2(string passwordLVL2)
        {
            bool result = false;
            UserApi user = new UserApi();
            user.Login = "Admin";
            user.Hash = passwordLVL2;

            var request = WebRequest.Create(Load.Server + "/users/check");
            request.ContentType = "application/json";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                streamWriter.Write(JsonConvert.SerializeObject(user));

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                result = Convert.ToBoolean(reader.ReadToEnd());
            }

            return result;
        }

    }
}
