using System;
using System.Collections.Generic;
using System.Data.Entity.Design;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class ServicioTarjetas : IServicioTarjetas
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}
	public List<Emisor> ObtenerEmisores()
	{
		Tarjetas3C2022Entities entities = new Tarjetas3C2022Entities();
		using (entities)
		{
			return entities.Emisor.ToList();
		}
	}

	public List<Emisor> ObtenerEmisoresPorNombre(string nombre)
	{
        Tarjetas3C2022Entities entities = new Tarjetas3C2022Entities();
        using (entities)
		{
			return entities.Emisor.ToList().Where(e => e.EMI_DESCRIPCION.Equals(nombre)).ToList();
		}

    }
	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
