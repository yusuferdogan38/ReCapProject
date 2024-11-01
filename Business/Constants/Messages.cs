﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Seçebileceğiniz arabalar listelendi";
        public static string CarDetail = "Arabanın özellikleri : ";
        public static string CarNameInvalid = "Tanım minimum 3 karakter olmalıdır.";
        public static string CarPriceInvalid = "Eklenen aracın günlük ücreti olmaldır.";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string GetCustomer = "Müşteri : ";


        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string GetBrand = "Seçtiğiniz Marka : ";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renk Listelendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string GetColour = "Seçtiğiniz Renk : ";

        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string RentalsListed = "Kiralamalar Listelendi";
        public static string GetRental = "Seçtiğiniz Kiralama : ";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string GetUser = "Seçtiğiniz Kullanıcı : ";


        public static string ImageLimitExceded = "en fazla 5 resim yükleyebilirsin";
    }
}
