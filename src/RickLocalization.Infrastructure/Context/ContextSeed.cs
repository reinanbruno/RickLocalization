using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RickLocalization.Infrastructure.Context
{
    public static class ContextSeed
    {
        private static int _countItemsDefault = 20;

        private static List<Rick> _listRicks;

        private static List<Morty> _listMorties;

        private static List<Dimension> _listDimensions;

        private static List<DimensionTravelled> _listDimensionsTravelled;

        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedDimensions();
            builder.SeedMorties();
            builder.SeedRicks();
            builder.SeedDimensionsTravelled();
        }
        private static void SeedDimensions(this ModelBuilder builder)
        {
            _listDimensions = new List<Dimension>();

            for (int index = 0; index < _countItemsDefault; index++)
            {
                _listDimensions.Add(
                    new Dimension
                    {
                        Id = Guid.NewGuid(),
                        Name = $"C-{130 + index}"
                    }
                );
            }

            builder.Entity<Dimension>(auth =>
            {
                auth.HasData(_listDimensions);
            });
        }
        private static void SeedDimensionsTravelled(this ModelBuilder builder)
        {
            _listDimensionsTravelled = new List<DimensionTravelled>();

            for (int index = 0; index < _countItemsDefault; index++)
            {
                _listDimensionsTravelled.Add(
                    new DimensionTravelled
                    {
                        Id = Guid.NewGuid(),
                        IdDimensionCurrent = _listDimensions[index].Id,
                        IdRick = _listRicks[index].Id,
                        RegistrationDate = DateTime.Now
                    }
                );

                int countTravels = new Random().Next(10, 20);
                int indexDimensionBefore = index;

                for (int indexTravel = 0; indexTravel < countTravels; indexTravel++)
                {
                    int indexDimensionCurrent = new Random().Next(0, _countItemsDefault - 1);

                    while (indexDimensionBefore == indexDimensionCurrent)
                    {
                        indexDimensionCurrent = new Random().Next(0, _countItemsDefault - 1);
                    }

                    _listDimensionsTravelled.Add(
                        new DimensionTravelled
                        {
                            Id = Guid.NewGuid(),
                            IdDimensionCurrent = _listDimensions[indexDimensionCurrent].Id,
                            IdDimensionBefore = _listDimensions[indexDimensionBefore].Id,
                            IdRick = _listRicks[index].Id,
                            RegistrationDate = DateTime.Now
                        }
                    );

                    indexDimensionBefore = indexDimensionCurrent;
                }
            }

            builder.Entity<DimensionTravelled>(auth =>
            {
                auth.HasData(_listDimensionsTravelled);
            });
        }
        private static void SeedMorties(this ModelBuilder builder)
        {
            _listMorties = new List<Morty>();

            for (int index = 0; index < _countItemsDefault; index++)
            {
                String image1 = "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg";
                String image2 = "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png";

                _listMorties.Add(
                    new Morty
                    {
                        Id = Guid.NewGuid(),
                        Name = $"Morty {index + 1}",
                        UrlImage = (index % 2 == 0 ? image1 : image2)
                    }
                );
            }

            builder.Entity<Morty>(auth =>
            {
                auth.HasData(_listMorties);
            });
        }
        private static void SeedRicks(this ModelBuilder builder)
        {
            _listRicks = new List<Rick>();

            for (int index = 0; index < _countItemsDefault; index++)
            {
                Dimension dimension = _listDimensions.FirstOrDefault(x => x.Id == _listDimensions[index].Id);
                String image1 = "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg";
                String image2 = "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg";

                _listRicks.Add(
                    new Rick
                    {
                        Id = Guid.NewGuid(),
                        IdMorty = _listMorties[index].Id,
                        IdDimensionOrigin = dimension.Id,
                        Name = $"Rick {index + 1}",
                        Url = $"rick-{index + 1}",
                        Description = $"O brilhante cientista beberrão Rick {index + 1} sequestra o Morty {index + 1}, seu neto " +
                                      $"aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick {index + 1} e o " +
                                      $"Morty {index + 1} tem como origem a dimensão {dimension.Name}.",
                        RegistrationDate = DateTime.Now,
                        UrlImage = (index % 2 == 0 ? image1 : image2)
                    }
                );
            }

            builder.Entity<Rick>(auth =>
            {
                auth.HasData(_listRicks);
            });
        }

    }
}
