using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC uygulama �zelliklerini etkinle�tirmek,hem de view'leri ve controller'lar� kullanabilmek i�in gerekli servisler

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(  
    name: "Default",   
    pattern: "{controller=home}/{action=index}"
);
app.Run();


/*
Controller: HTTP isteklerini i�leyen s�n�ft�r ve kullan�c�dan gelen istekleri modelle i�leyip uygun view'lar� geri d�ner.

Action: Controller i�indeki bir metot olup belirli bir URL'ye yan�t verir ve i� mant���n� uygular.

Model: Uygulaman�n veri yap�s�n� temsil eder; genellikle veri taban� ile etkile�im kurar ve uygulama i�i verileri ta��r.

View: Kullan�c�ya g�sterilen aray�zd�r. Model verilerini al�p HTML ��kt�s� �retir.

Razor: ASP.NET uygulamalar�nda dinamik HTML sayfalar� olu�turmak i�in kullan�lan bir �ablon motorudur.

RazorView: Razor �ablonlar�n� kullanarak olu�turulan ve dinamik olarak HTML i�eri�i �reten view�dir.

wwwroot: Statik dosyalar�n(CSS, JavaScript, resimler vb.) bulundu�u k�k klas�rd�r ve web taray�c�s� taraf�ndan do�rudan eri�ilebilir.

builder.Build(): ASP.NET Core uygulamas�n�n yap�land�rma ve servislerini belirledikten sonra, uygulama �rne�ini olu�turur.

app.Run(): Uygulaman�n istekleri i�leme s�recini ba�lat�r; genellikle uygulaman�n ana �al��t�rma ak���n� tan�mlar.

*/