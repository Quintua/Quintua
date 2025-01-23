using cmd;

namespace QUINTUACLASS
{
    internal class phone_brand
    {
        static void Main(string[] args)
        {
        
            Data data = new Data();
            List<programa> programas = data.Table_1();

            foreach (var program in programas)
            {
               Console.WriteLine($"Name: { program.phoneBrand}");

            }
            
            //FILTER//
            List<programa> phonedevice = programas.Where(x => x.phoneBrand == "Samsung").ToList();
            Console.WriteLine($"List of Samsung user: {phonedevice.Count}");
            foreach (var program in phonedevice)
            {
                Console.WriteLine($"List of Samsung Device: {program.devicereleasedate} ");
            }

            //ORDER BY
            List<programa> devicemodel = phonedevice.OrderBy(x => x.devicetype).ToList();
            foreach (var program in devicemodel)
            {
                Console.WriteLine($"Type and Releasedate: {program.devicetype} {program.devicereleasedate} ");

            }

            //Group 
            var grouped = programas.GroupBy(x => x.phoneBrand);
            foreach (var program in grouped)
            {
                Console.WriteLine($" List of device : {program.Key}");
            }






















            //programa phone1 = new programa();
            //phone1.phoneBrand = "Iphone";
            //phone1.devicereleasedate = 2019;
            //phone1.devicetype = "IOS";
            //phone1.devicemodel = "Iphone 11";

            //programa phone2 = new programa();
            //phone2.phoneBrand = "Samsung";
            //phone2.devicereleasedate = 2015;
            //phone2.devicetype = "Android";
            //phone2.devicemodel = "J11";

            //programa phone3 = new programa();
            //phone3.phoneBrand = "XIAMI";
            //phone3.devicereleasedate = 2020;
            //phone3.devicetype = "Android";
            //phone3.devicemodel = "XIAMI 11";

            //List<programa> programa = new List<programa>();

            //programa.Add(phone1);
            //programa.Add(phone2);
            //programa.Add(phone3);


            //foreach (var phone in programa)
            //{
            //    Console.WriteLine($"Brand of the phone: {phone.phoneBrand}");
            //    Console.WriteLine($"Cost of the phone: {phone.devicereleasedate}");
            //    Console.WriteLine($"Type of the phone: {phone.devicetype}");
            //    Console.WriteLine($"Type of the phone: {phone.devicemodel}");
            //    Console.WriteLine();


            //}
        }
    }
}
