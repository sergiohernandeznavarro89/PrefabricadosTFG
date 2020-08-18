using AutoMapper;
using Database.BD.Models;
using Service.DTO;

namespace Service.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //origen Cliente destino ClienteDTO            
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Empleado, EmpleadoDTO>();
            CreateMap<EmpleadoDTO, Empleado>();
            CreateMap<Horma, HormaDTO>();
            CreateMap<TroquelTapa, TroquelTapaDTO>();
            CreateMap<Escandallo, EscandalloDTO>();
            CreateMap<ClienteFormaPago, ClienteFormaPagoDTO>();
            CreateMap<RemesaCliente, RemesaClienteDTO>();
            CreateMap<Cobro, CobroDTO>();
            CreateMap<Pedido, PedidoDTO>();
            CreateMap<HormaTroquelPiso, HormaTroquelPisoDTO>();
            CreateMap<HormaTroquelTapa, HormaTroquelTapaDTO>();
            CreateMap<TroquelPiso, TroquelPisoDTO>();
            CreateMap<AlturaPiso, AlturaPisoDTO>();
            CreateMap<AlturaTapa, AlturaTapaDTO>();
            CreateMap<ColorCerco, ColorCercoDTO>();
            CreateMap<ColorPiso, ColorPisoDTO>();
            CreateMap<ColorTapa, ColorTapaDTO>();
            CreateMap<ColorTintado, ColorTintadoDTO>();
            CreateMap<MaterialCerco, MaterialCercoDTO>();
            CreateMap<MaterialPiso, MaterialPisoDTO>();
            CreateMap<MaterialTapa, MaterialTapaDTO>();
            CreateMap<Trabajo, TrabajoDTO>();
            CreateMap<Serie, SerieDTO>();
            CreateMap<EscandalloPedido, EscandalloPedidoDTO>();
            CreateMap<LineaSerieEscandallo, LineaSerieEscandalloDTO>();
            CreateMap<FormaPago, FormaPagoDTO>();
            CreateMap<Remesa, RemesaDTO>();
            CreateMap<Albaran, AlbaranDTO>();
            CreateMap<Factura, FacturaDTO>();
            CreateMap<LineaSeriePedido, LineaSeriePedidoDTO>();
        }
    }
}
