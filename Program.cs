using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Ohjelma aloittaa");

        // b niinkuin Builder
        var b = WebApplication.CreateBuilder();

        b.Services.AddControllers();

        // w niinkuij WebApp
        var w = b.Build(); // Luo valmiin web application, joka seuraavaksi voidaan käynnistää

        w.MapControllers();
        
        w.Run();


        Console.WriteLine("Ohjelma lopettaa");
    } 
}