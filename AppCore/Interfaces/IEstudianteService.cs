﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace AppCore.Interfaces
{
    public interface IEstudianteService : IService<Estudiante>
    {
        List<Estudiante> FindAll(Predicate<Estudiante> predicate);
    }
}
