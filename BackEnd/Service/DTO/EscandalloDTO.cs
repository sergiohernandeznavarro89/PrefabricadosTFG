using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class EscandalloDTO
    {
        public int IdEscandallo { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public int DescuentoPrecio { get; set; }
        public int SubidaPrecio { get; set; }



        #region RELACIONES        
        public ClienteDTO Cliente { get; set; }
        //-------------        
        public HormaDTO Horma { get; set; }
        //-------------        
        public TroquelPisoDTO TroquelPiso { get; set; }
        //-------------       
        public TroquelTapaDTO TroquelTapa { get; set; }
        //-------------                
        public AlturaPisoDTO AlturaPiso { get; set; }
        //-------------               
        public AlturaTapaDTO AlturaTapa { get; set; }
        //-------------       
        public ColorCercoDTO ColorCerco { get; set; }
        //-------------               
        public ColorPisoDTO ColorPîso { get; set; }
        //-------------        
        public ColorTapaDTO ColorTapa { get; set; }
        //-------------       
        public ColorTintadoDTO ColorTintado { get; set; }
        //-------------        
        public MaterialCercoDTO MaterialCerco { get; set; }
        //-------------       
        public MaterialPisoDTO MaterialPiso { get; set; }
        //-------------        
        public MaterialTapaDTO MaterialTapa { get; set; }
        //-------------        
        public TrabajoDTO Trabajo { get; set; }
        //-------------       
        public SerieDTO Serie { get; set; }
        //-------------
        public ICollection<EscandalloPedidoDTO> EscandallosPedidos { get; set; }
        public ICollection<LineaSerieEscandalloDTO> LineasSerieEscandallos { get; set; }
        #endregion

    }
}
