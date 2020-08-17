using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class PedidoDTO
    {
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaServicio { get; set; }
        public string CodigoPedidoCliente { get; set; }
        public int PrecioTotal { get; set; }


        #region RELACIONES
        public ClienteDTO Cliente { get; set; }
        //--------------------
        public FormaPagoDTO FormaPago { get; set; }
        //-------------
        public TrabajoDTO Trabajo { get; set; }
        //-------------
        public MaterialPisoDTO MaterialPiso { get; set; }
        //-------------
        public AlturaPisoDTO AlturaPiso { get; set; }
        //-------------
        public ColorPisoDTO ColorPiso { get; set; }
        //-------------
        public MaterialTapaDTO MaterialTapa { get; set; }
        //-------------
        public AlturaTapaDTO AlturaTapa { get; set; }
        //-------------
        public ColorTapaDTO ColorTapa { get; set; }
        //-------------
        public MaterialCercoDTO MaterialCerco { get; set; }
        //-----------
        public ColorCercoDTO ColorCerco { get; set; }
        //-------------
        public HormaDTO Horma { get; set; }
        //-------------
        public TroquelPisoDTO TroquelPiso { get; set; }
        //-------------        
        public TroquelTapaDTO TroquelTapa { get; set; }
        //-------------
        public ColorTintadoDTO ColorTintado { get; set; }
        //-------------
        public SerieDTO Serie { get; set; }
        //-------------                    
        public AlbaranDTO Albaran { get; set; }
        //-------------
        public FacturaDTO Factura { get; set; }
        //-------------

        public ICollection<LineaSeriePedidoDTO> LineasSeriePedidos { get; set; }
        public ICollection<EscandalloPedidoDTO> EscandallosPedidos { get; set; }
        public ICollection<CobroDTO> Cobros { get; set; }
        #endregion                
    }
}
