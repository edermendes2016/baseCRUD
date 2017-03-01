﻿using System;

namespace appCRUD.Dominio.Modelos
{
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        
    }
}