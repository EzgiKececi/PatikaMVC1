using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC uygulama özelliklerini etkinleþtirmek,hem de view'leri ve controller'larý kullanabilmek için gerekli servisler

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(  
    name: "Default",   
    pattern: "{controller=home}/{action=index}"
);
app.Run();


/*
Controller: HTTP isteklerini iþleyen sýnýftýr ve kullanýcýdan gelen istekleri modelle iþleyip uygun view'larý geri döner.

Action: Controller içindeki bir metot olup belirli bir URL'ye yanýt verir ve iþ mantýðýný uygular.

Model: Uygulamanýn veri yapýsýný temsil eder; genellikle veri tabaný ile etkileþim kurar ve uygulama içi verileri taþýr.

View: Kullanýcýya gösterilen arayüzdür. Model verilerini alýp HTML çýktýsý üretir.

Razor: ASP.NET uygulamalarýnda dinamik HTML sayfalarý oluþturmak için kullanýlan bir þablon motorudur.

RazorView: Razor þablonlarýný kullanarak oluþturulan ve dinamik olarak HTML içeriði üreten view’dir.

wwwroot: Statik dosyalarýn(CSS, JavaScript, resimler vb.) bulunduðu kök klasördür ve web tarayýcýsý tarafýndan doðrudan eriþilebilir.

builder.Build(): ASP.NET Core uygulamasýnýn yapýlandýrma ve servislerini belirledikten sonra, uygulama örneðini oluþturur.

app.Run(): Uygulamanýn istekleri iþleme sürecini baþlatýr; genellikle uygulamanýn ana çalýþtýrma akýþýný tanýmlar.

*/