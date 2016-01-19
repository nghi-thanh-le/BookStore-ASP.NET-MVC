using BookStore_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore_MVC.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var publishers = new List<Publisher>
            {
                new Publisher {PublisherName = "Wrox" },
                new Publisher {PublisherName = "Wiley" },
                new Publisher {PublisherName = "O'Reilly Media" },
                new Publisher {PublisherName = "Apress" },
                new Publisher {PublisherName = "Packt Publishing" },
                new Publisher {PublisherName = "Addison-Wesley" }
            };

            var books = new List<Book>
            {
                new Book {
                    BookIsbn = "978-0-321-94786-4",
                    BookTitle = "Learning Mobile App Development",
                    BookAuthor = "Jakob Iversen, Michael Eierman",
                    BookImage = "mobile_app.jpg",
                    BookDescr = "Now, one book can help you master mobile app development with both market-leading platforms: Apple's iOS and Google's Android. Perfect for both students and professionals, Learning Mobile App Development is the only tutorial with complete parallel coverage of both iOS and Android. With this guide, you can master either platform, or both - and gain a deeper understanding of the issues associated with developing mobile apps. You'll develop an actual working app on both iOS and Android, mastering the entire mobile app development lifecycle, from planning through licensing and distribution. Each tutorial in this book has been carefully designed to support readers with widely varying backgrounds and has been extensively tested in live developer training courses. If you're new to iOS, you'll also find an easy, practical introduction to Objective-C, Apple's native language.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Addison-Wesley")
                },
                new Book {
                    BookIsbn = "978-0-7303-1484-4",
                    BookTitle = "Doing Good By Doing Good",
                    BookAuthor = "Peter Baines",
                    BookImage = "doing_good.jpg",
                    BookDescr = "Doing Good by Doing Good shows companies how to improve the bottom line by implementing an engaging, authentic, and business-enhancing program that helps staff and business thrive. International CSR consultant Peter Baines draws upon lessons learnt from the challenges faced in his career as a police officer, forensic investigator, and founder of Hands Across the Water to describe the Australian CSR landscape, and the factors that make up a program that benefits everyone involved. Case studies illustrate the real effect of CSR on both business and society, with clear guidance toward maximizing involvement, engaging all employees, and improving the bottom line. The case studies draw out the companies that are focusing on creating shared value in meeting the challenges of society whilst at the same time bringing strong economic returns. Consumers are now expecting that big businesses with ever-increasing profits give back to the community from which those profits arise. At the same time, shareholders are demanding their share and are happy to see dividends soar. Getting this right is a balancing act, and Doing Good by Doing Good helps companies delineate a plan of action for getting it done.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Wiley")
                },
                new Book {
                    BookIsbn = "978-1-118-94924-5",
                    BookTitle = "Programmable Logic Controllers",
                    BookAuthor = "Dag H. Hanssen",
                    BookImage = "logic_program.jpg",
                    BookDescr = "Widely used across industrial and manufacturing automation, Programmable Logic Controllers (PLCs) perform a broad range of electromechanical tasks with multiple input and output arrangements, designed specifically to cope in severe environmental conditions such as automotive and chemical plants. Programmable Logic Controllers: A Practical Approach using CoDeSys is a hands - on guide to rapidly gain proficiency in the development and operation of PLCs based on the IEC 61131 - 3 standard.Using the freely - available * software tool CoDeSys, which is widely used in industrial design automation projects, the author takes a highly practical approach to PLC design using real - world examples.The design tool, CoDeSys, also features a built in simulator / soft PLC enabling the reader to undertake exercises and test the examples.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Wiley")
                },
                new Book {
                    BookIsbn = "978-1-1180-2669-4",
                    BookTitle = "Professional JavaScript for Web Developers, 3rd Edition",
                    BookAuthor = "Nicholas C. Zakas",
                    BookImage = "pro_js.jpg",
                    BookDescr = "If you want to achieve JavaScript's full potential, it is critical to understand its nature, history, and limitations. To that end, this updated version of the bestseller by veteran author and JavaScript guru Nicholas C. Zakas covers JavaScript from its very beginning to the present-day incarnations including the DOM, Ajax, and HTML5. Zakas shows you how to extend this powerful language to meet specific needs and create dynamic user interfaces for the web that blur the line between desktop and internet. By the end of the book, you'll have a strong understanding of the significant advances in web development as they relate to JavaScript so that you can apply them to your next website.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Wrox")
                },
                new Book {
                    BookIsbn = "978-1-44937-019-0",
                    BookTitle = "Learning Web App Development",
                    BookAuthor = "Semmy Purewal",
                    BookImage = "web_app_dev.jpg",
                    BookDescr = "Grasp the fundamentals of web application development by building a simple database-backed app from scratch, using HTML, JavaScript, and other open source tools. Through hands-on tutorials, this practical guide shows inexperienced web app developers how to create a user interface, write a server, build client-server communication, and use a cloud-based service to deploy the application. Each chapter includes practice problems, full examples, and mental models of the development workflow. Ideal for a college-level course, this book helps you get started with web app development by providing you with a solid grounding in the process.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "O'Reilly Media")
                },
                new Book {
                    BookIsbn = "978-1-44937-075-6",
                    BookTitle = "Beautiful JavaScript",
                    BookAuthor = "Anton Kovalyov",
                    BookImage = "beauty_js.jpg",
                    BookDescr = "JavaScript is arguably the most polarizing and misunderstood programming language in the world. Many have attempted to replace it as the language of the Web, but JavaScript has survived, evolved, and thrived. Why did a language created in such hurry succeed where others failed? This guide gives you a rare glimpse into JavaScript from people intimately familiar with it. Chapters contributed by domain experts such as Jacob Thornton, Ariya Hidayat, and Sara Chipps show what they love about their favorite language - whether it's turning the most feared features into useful tools, or how JavaScript can be used for self-expression.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "O'Reilly Media")
                },
                new Book {
                    BookIsbn = "978-1-4571-0402-2",
                    BookTitle = "Professional ASP.NET 4 in C# and VB",
                    BookAuthor = "Scott Hanselman",
                    BookImage = "pro_asp4.jpg",
                    BookDescr = "ASP.NET is about making you as productive as possible when building fast and secure web applications. Each release of ASP.NET gets better and removes a lot of the tedious code that you previously needed to put in place, making common ASP.NET tasks easier. With this book, an unparalleled team of authors walks you through the full breadth of ASP.NET and the new and exciting capabilities of ASP.NET 4. The authors also show you how to maximize the abundance of features that ASP.NET offers to make your development process smoother and more efficient.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Wrox")
                },
                new Book {
                    BookIsbn = "978-1-484216-40-8",
                    BookTitle = "Android Studio New Media Fundamentals",
                    BookAuthor = "Wallace Jackson",
                    BookImage = "android_studio.jpg",
                    BookDescr = "Android Studio New Media Fundamentals is a new media primer covering concepts central to multimedia production for Android including digital imagery, digital audio, digital video, digital illustration and 3D, using open source software packages such as GIMP, Audacity, Blender, and Inkscape. These professional software packages are used for this book because they are free for commercial use. The book builds on the foundational concepts of raster, vector, and waveform (audio), and gets more advanced as chapters progress, covering what new media assets are best for use with Android Studio as well as key factors regarding the data footprint optimization work process and why new media content and new media data optimization is so important.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Apress")
                },
                new Book {
                    BookIsbn = "978-1-484217-26-9",
                    BookTitle = "C++ 14 Quick Syntax Reference, 2nd Edition",
                    BookAuthor = "Mikael Olsson",
                    BookImage = "c_14_quick.jpg",
                    BookDescr = "This updated handy quick C++ 14 guide is a condensed code and syntax reference based on the newly updated C++ 14 release of the popular programming language. It presents the essential C++ syntax in a well-organized format that can be used as a handy reference. You won't find any technical jargon, bloated samples, drawn out history lessons, or witty stories in this book. What you will find is a language reference that is concise, to the point and highly accessible. The book is packed with useful information and is a must-have for any C++ programmer. In the C++ 14 Quick Syntax Reference, Second Edition, you will find a concise reference to the C++ 14 language syntax. It has short, simple, and focused code examples. This book includes a well laid out table of contents and a comprehensive index allowing for easy review.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "Apress")
                },
                new Book {
                    BookIsbn = "978-1-49192-706-9",
                    BookTitle = "C# 6.0 in a Nutshell, 6th Edition",
                    BookAuthor = "Joseph Albahari, Ben Albahari",
                    BookImage = "c_sharp_6.jpg",
                    BookDescr = "When you have questions about C# 6.0 or the .NET CLR and its core Framework assemblies, this bestselling guide has the answers you need. C# has become a language of unusual flexibility and breadth since its premiere in 2000, but this continual growth means there's still much more to learn. Organized around concepts and use cases, this thoroughly updated sixth edition provides intermediate and advanced programmers with a concise map of C# and .NET knowledge. Dive in and discover why this Nutshell guide is considered the definitive reference on C#.",
                    BookPrice = 20.00m,
                    Publisher = publishers.Single(p => p.PublisherName == "O'Reilly Media")
                }
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}