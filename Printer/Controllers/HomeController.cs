using ceTe.DynamicPDF.Printing;
using System.Drawing.Printing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;

namespace Printer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Printing()
        {

            try
            {
                string path = "C:\\imprimir\\fichaFulano.pdf";
                string printName = "Canon - 75"; //Canon - 75 ou Printronix - 102
                //PrintDocument pd = new();
                //var teste = pd.PrinterSettings.PrintFileName = "192.168.1.75";

                Process p = new Process(); //responsável pela impressão a partir de um visualizador de pdf padrão.
                p.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true, //usa cmd | responsável por habilitar o metodo em asp core. Sem isso não funciona
                    CreateNoWindow = true, //define a impressão sem exibir tela de aviso. 
                    Verb = "printTo",
                    //Arguments = "c:\\Dayhosp-155\\Canon - 75",
                    Arguments = "\"" + printName + "\"", //responsável por apontar a impressora
                    FileName = path, //caminho + arquivo || apenas arquivo
                    WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),

                };
                

                p.Start();
                p.WaitForExit();

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
