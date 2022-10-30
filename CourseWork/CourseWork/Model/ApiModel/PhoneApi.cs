
namespace CourseWork.Model.ApiModel
{
    class PhoneApi
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public PhoneApi(int ClientID, string name, string phoneNumber)
        {
            this.ClientID = ClientID;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
    }
}
