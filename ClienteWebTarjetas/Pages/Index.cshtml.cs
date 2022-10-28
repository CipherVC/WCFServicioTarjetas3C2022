using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServicioTarjetas;

namespace ClienteWebTarjetas.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<ServicioTarjetas.Emisor> Emisores = new List<Emisor>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ServicioTarjetas.ServicioTarjetasClient servicio = new ServicioTarjetas.ServicioTarjetasClient();
            this.Emisores = servicio.ObtenerEmisoresAsync().Result.ToList();

        }
    }
}