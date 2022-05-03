using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInValid = "Ürün ismi geçersiz.";
        internal static string MaintenanceTime="Sistem bakımda.";
        internal static string ProductsListed="Ürünler listelendi.";
        internal static string ProductNameAlreadyExist="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt olundu.";
        public  static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Access token oluşturuldu.";
    }
}
