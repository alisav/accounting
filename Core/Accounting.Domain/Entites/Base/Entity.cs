﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entites.Base
{
    public abstract class Entity : IBaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; protected set; }

        public Entity Clone()
        {
            return (Entity)this.MemberwiseClone();
        }
    }
}
