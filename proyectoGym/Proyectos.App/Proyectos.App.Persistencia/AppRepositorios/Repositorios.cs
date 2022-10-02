using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class Repositorios : IRepositorios
    {
       private readonly AppContext _appContext;
       public IEnumerable<Entrenador> entrenador {get; set;} 
       public IEnumerable<Usuario> usuario {get; set;} 
       public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
        //SIGUIENTE DIAPOSITIVA

        Entrenador IRepositorios.AddEntrenador(Entrenador entrenador)
        {
        try
         {
            var EntrenadorAdicionado = _appContext.entrenador.Add( entrenador );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return EntrenadorAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Entrenador> IRepositorios.GetAllEntrenadores(string? searchString)
        {
            if (searchString == null)
                entrenador = _appContext.entrenador;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                entrenador = _appContext.entrenador.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                //formadores = _appContext.formador.Where(s => s.identificacion.Equals(searchString));    
            }
            return entrenador;
        }

       Entrenador IRepositorios.GetEntrenador(int? idEntrenador)
       {
            return _appContext.entrenador.FirstOrDefault(p => p.id == idEntrenador);
       }

       Entrenador IRepositorios.UpdateEntrenador (Entrenador entrenador)
        {    
            var EntrenadorEncontrado = _appContext.entrenador.FirstOrDefault(p => p.id == entrenador.id);
            if (EntrenadorEncontrado != null)
            {
                EntrenadorEncontrado.identificacion  = entrenador.identificacion;
                EntrenadorEncontrado.nombre          = entrenador.nombre;
                EntrenadorEncontrado.apellido        = entrenador.apellido;
                EntrenadorEncontrado.telefono        = entrenador.telefono;
                EntrenadorEncontrado.mail            = entrenador.mail;
                EntrenadorEncontrado.edad            = entrenador.edad;
                EntrenadorEncontrado.rutid          = entrenador.rutid;
                _appContext.SaveChanges();
            }
            return EntrenadorEncontrado;
        }

        void IRepositorios.DeleteEntrenador(int idEntrenador)
        {   
            var EntrenadorEncontrado = _appContext.entrenador.FirstOrDefault(p => p.id == idEntrenador);
            if (EntrenadorEncontrado != null){                
                _appContext.entrenador.Remove(EntrenadorEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //repositorio para Usuario
        Usuario IRepositorios.AddUsuario(Usuario usuario)
        {
        try
         {
            var UsuarioAdicionado = _appContext.usuario.Add( usuario );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return UsuarioAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Usuario> IRepositorios.GetAllUsuarios(string? searchString)
        {
            if (searchString == null)
                usuario = _appContext.usuario;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                //tutores = _appContext.tutor.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                usuario = _appContext.usuario.Where(s => s.identificacion.Equals(searchString));    
            }
            return usuario;
        }

       Usuario IRepositorios.GetUsuario(int? idUsuario)
       {
            return _appContext.usuario.FirstOrDefault(p => p.id == idUsuario);
       }

       Usuario IRepositorios.UpdateUsuario(Usuario usuario)
        {    
            var UsuarioEncontrado = _appContext.usuario.FirstOrDefault(p => p.id == usuario.id);
            if (UsuarioEncontrado != null)
            {
                UsuarioEncontrado.identificacion  = usuario.identificacion;
                UsuarioEncontrado.nombre          = usuario.nombre;
                UsuarioEncontrado.apellido        = usuario.apellido;
                UsuarioEncontrado.telefono        = usuario.telefono;
                UsuarioEncontrado.mail           = usuario.mail;
                UsuarioEncontrado.edad            = usuario.edad;
                UsuarioEncontrado.plan            = usuario.plan;
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }

        void IRepositorios.DeleteUsuario(int idUsuario)
        {   
            var UsuarioEncontrado = _appContext.usuario.FirstOrDefault(p => p.id == idUsuario);
            if (UsuarioEncontrado != null){                
                _appContext.usuario.Remove(UsuarioEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

       

    } //fin repositorios
}

