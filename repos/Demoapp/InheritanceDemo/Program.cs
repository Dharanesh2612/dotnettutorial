namespace InheritanceDemo;


class Program 
{ 
   
            private static void Main(string[] args)
            {
                Company c = new Company();
               
                c.addressline = "SIPCOT,Siruseri";
                c.city = "Chennai";
                c.state = "Tamil Nadu";
                c.postcode = "postcode-630211";
                c.email = "contact@cp.com";
                c.phonenumber = "phone number is 98765432";
                c.addressDetails();
                c.getcontactdetails();

                Employee e = new Employee();
               
                
                e.addressline = "SIPCOT,Siruseri";
                
                e.city = "Chennai";
                e.state = "Tamil Nadu";
                e.postcode = "this is phone number 345678989";
                e.email = "contact@cp.com";
                e.phonenumber= "987654321";
                e.addressDetails();
                e.getcontactdetails();

            }
        }
