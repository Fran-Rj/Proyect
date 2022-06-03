using PlayMovieSite.Models;
using PlayMovieSite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayMovieSite.Repository
{
    public class ClsTarjeta : ITarjeta
    {
        public void Create(Tarjeta tarjeta)
        {
            using (PlayMovieDB conexionBd = new PlayMovieDB())
            {
                try
                {
                    conexionBd.Tarjeta.Add(tarjeta);
                    conexionBd.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }    

        public void Update(Tarjeta tarjeta)
        {
            using (PlayMovieDB conexionBd = new PlayMovieDB())
            {
                Tarjeta tarjt = conexionBd.Tarjeta.Find(tarjeta.idTarjeta);
                tarjt.numTarjeta = tarjeta.numTarjeta;
                conexionBd.SaveChanges();
            }
        }

        public void Delete(Tarjeta tarjeta)
        {
            using (PlayMovieDB conexionBd = new PlayMovieDB())
            {
                tarjeta = conexionBd.Tarjeta.Find(tarjeta.idTarjeta);
                conexionBd.Tarjeta.Remove(tarjeta);
                conexionBd.SaveChanges();
            }
        }

        public List<Tarjeta> CardList()
        {
            using (PlayMovieDB conexionBd = new PlayMovieDB())
            {
                List<Tarjeta> TargetDataList = conexionBd.Tarjeta.ToList();
                return TargetDataList;
            }
        }

        public Tarjeta Buscar(int Id)
        {
            using (PlayMovieDB conexionBd = new PlayMovieDB())
            {
                Tarjeta tarjeta = conexionBd.Tarjeta.Find(Id);

                return tarjeta;
            }
        }
    }
}