using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();

            //ColorTest();

            //CustomerTest();

            //UserTest();

            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManeger rentalManeger = new RentalManeger(new EfRentalDal());
            Rental rental1 = new Rental { CarId = 2, BrandId = 1, CustomerId = 1, RentDeta = new DateTime(2021, 02, 16) };
            //rentalManeger.Add(rental1);

            foreach (var rental in rentalManeger.GetAll().Data)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", rental.RentalId, rental.CarId, rental.BrandId, rental.CustomerId, rental.RentDeta, rental.ReturnDate);
            }
        }

        private static void UserTest()
        {
            UserManeger userManeger = new UserManeger(new EfUserDal());

            foreach (var user in userManeger.GetAll().Data)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}", user.UserId, user.FirstName, user.LastName, user.Email, user.Password);
            }
        }

        private static void CustomerTest()
        {
            CustomerManeger customerManeger = new CustomerManeger(new EfCustomerDal());

            foreach (var customer in customerManeger.GetAll().Data)
            {
                Console.WriteLine("{0}-{1}-{2}", customer.CustomerId, customer.CustomerId, customer.CompanyName);
            }
        }

        private static void ColorTest()
        {
            ColorManeger colorManeger = new ColorManeger(new EfColorDal());

            //Ekleme
            /*var addedResualt = colorManeger.Add(new Color { ColorName = "Pembe" });
            Console.WriteLine(addedResualt.Message);*/

            //Güncelleme
            /*var updatedResualt = colorManeger.Update(new Color { ColorId =1002 ,ColorName = "Lacivert" });
            Console.WriteLine(updatedResualt.Message); */

            //Silme
            /*var deletedResualt = colorManeger.Delete(new Color { ColorId = 1002});
            Console.WriteLine(deletedResualt.Message);*/

            //Listeleme
            foreach (var color in colorManeger.GetAll().Data)
            {
                Console.WriteLine("{0}-{1}", color.ColorId, color.ColorName);
            }

            //ColorId göre Getirme
            /*var color = colorManeger.GetByColorId(5).Data;
            Console.WriteLine("{0}-{1}", color.ColorId, color.ColorName);*/
        }

        private static void BrandTest()
        {
            BrandManeger brandManeger = new BrandManeger(new EfBrandDal());

            //Ekleme
            /*var addedResualt = brandManeger.Add(new Brand { BrandName = "Nisssan" });
            Console.WriteLine(addedResualt.Message);*/

            //Güncelleme
            //var updatedResualt = brandManeger.Update(new Brand { BrandId =1002 ,BrandName = "asd" });
            //Console.WriteLine(updatedResualt.Message);

            //Silme
            /*var deletedResualt = brandManeger.Delete(new Brand { BrandId = 1002});
            Console.WriteLine(deletedResualt.Message);*/

            //Listeleme
            foreach (var brand in brandManeger.GetAll().Data)
            {
                Console.WriteLine("{0}-{1}", brand.BrandId, brand.BrandName);
            }

            //BrandId göre Getirme
            /*var brnad = brandManeger.GetByBrandId(1).Data;
            Console.WriteLine("{0}-{1}", brnad.BrandId, brnad.BrandName);*/
        }

        private static void CarTest()
        {
            CarManeger carManeger = new CarManeger(new EfCarDal());

            //Listeleme
            /*var listResualt = carManeger.GetAll();
            if (listResualt.Success)
            {
                foreach (var car in listResualt.Data)
                {
                    Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", car.CarId, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);
                }
            }
            else
            {
                Console.WriteLine(listResualt.Message);
            }*/

            //BrandId göre listeleme
            /*foreach (var car in carManeger.GetByBrandId(2).Data)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", car.CarId, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);
            }*/

            //ColorId göre listeleme
            /*foreach (var car in carManeger.GetByColorId(3).Data)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", car.CarId, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);
            }*/

            // CarId ye Göre Listeleme
            /*var car = carManeger.GetByCarId(1).Data;
             Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", car.CarId, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);*/

            //Ekleme
            /*var addedResualt = carManeger.Add(new Car { BrandId = 3, ColorId = 1, DailyPrice = 550, ModelYear = "2017", Description = "Manuel Vites" });
            if (addedResualt.Success)
            {
                Console.WriteLine(addedResualt.Message); 
            }
            else
            {
                Console.WriteLine(addedResualt.Message);
            }*/

            //Güncelleme
            /*var updatedResualt = carManeger.Update(new Car { CarId = 3010, BrandId = 1, ColorId = 1, DailyPrice = 575, ModelYear = "2015", Description = "Manuel Vites" });
            if (updatedResualt.Success)
            {
                Console.WriteLine( updatedResualt.Message);
            }
            else
            {
                Console.WriteLine(updatedResualt.Message);
            }*/

            //Silme
            //var deleteResualt = carManeger.Delete(new Car { CarId = 3010 });
            //if (deleteResualt.Success)
            //{
            //    Console.WriteLine(deleteResualt.Message);
            //}
            //else
            //{
            //    Console.WriteLine(deleteResualt.Message);
            //}
        }
    }
}
