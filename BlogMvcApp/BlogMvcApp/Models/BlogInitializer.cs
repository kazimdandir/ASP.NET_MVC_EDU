using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName = "C#"},
                new Category(){CategoryName = "Asp.net MVC"},
                new Category(){CategoryName = "Asp.net Web Form"},
                new Category(){CategoryName = "Windows Form"},
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();


            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){Title = "C# Deletagtes Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-10), HomePage = true, Approval = false, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="1.jpg", CategoryId = 1},

                 new Blog(){Title = "C# Deletagtes", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-20), HomePage = false, Approval = true, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="1.jpg", CategoryId = 1},

                  new Blog(){Title = "C# Deletagtes Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-5),  HomePage = false, Approval = false, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="2.jpg", CategoryId = 2},

                   new Blog(){Title = "C# Generic List Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-30), HomePage = true, Approval = false, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="2.jpg", CategoryId = 2},

                    new Blog(){Title = "C# Deletagtes Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-7), HomePage = true, Approval = true, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="3.jpg", CategoryId = 3},

                     new Blog(){Title = "C# Deletagtes Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-14), HomePage = false, Approval = false, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="3.jpg", CategoryId = 3},

                     new Blog(){Title = "C# Deletagtes Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-5), HomePage = false, Approval = true, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="4.jpg", CategoryId = 4},

                      new Blog(){Title = "C# Deletagtes Hakkında", Description = "C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.", DateOfUpload = DateTime.Now.AddDays(-20), HomePage = true, Approval = true, Content = "C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur. Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.", Picture="4.jpg", CategoryId = 4}
            };

            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}