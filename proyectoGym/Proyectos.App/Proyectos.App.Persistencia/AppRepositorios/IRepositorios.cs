//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Modelos;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public interface IRepositorios
    {
        //contratos o firmas para los metodos Entrenador        
        Entrenador AddEntrenador(Entrenador entrenador);
        IEnumerable<Entrenador> GetAllEntrenadores(string? searchString);         
        Entrenador GetEntrenador(int? idEntrenador);
        Entrenador UpdateEntrenador(Entrenador entrenador);
        void DeleteEntrenador(int idEntrenador); 

        

        //contratos o firmas para los metodos Usuario        
        Usuario AddUsuario(Usuario usuario);
        IEnumerable<Usuario> GetAllUsuarios(string? searchString);         
        Usuario GetUsuario(int? idUsuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario); 




    } //fin IRepositorios
}



