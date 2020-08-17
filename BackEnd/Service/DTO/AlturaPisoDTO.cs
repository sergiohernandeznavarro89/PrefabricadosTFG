﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.DTO
{
    public class AlturaPisoDTO
    {
        public string IdAlturaPiso { get; set; }
        public string Nombre { get; set; }
        public int Grosor { get; set; }
        public string Descripcion { get; set; }


        #region RELACIONES
        public ICollection<EscandalloDTO> Escandallos { get; set; }                
        public ICollection<PedidoDTO> Pedidos { get; set; }                
        public ICollection<AlturaPisoMaterialPisoDTO> AlturasPisoMaterialesPiso { get; set; }
        #endregion

    }
}