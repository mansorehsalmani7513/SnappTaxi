using System;
using System.Collections.Generic;
using System.Text;
using Snapp.DataAccessLayer.Context;
using Snapp.Core.Interfaces;
using Snapp.Core.ViewModels.Admin;
using System.Threading.Tasks;
using Snapp.DataAccessLayer.Entites;
using Snapp.Core.Generators;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Snapp.Core.Services
{
    public class AdminService : IAdmin
    {
        private DatabaseContext _context;

        public AdminService(DatabaseContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void AddCar(CarViewModel viewModel)
        {
            Car car = new Car()
            {
                Id = CodeGenerators.GetId(),
                Name = viewModel.Name
            };

            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void DeleteCar(Guid id)
        {
            Car car = _context.Cars.Find(id);

            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();

               
            }
        }

        public async Task<Car> GetCarById(Guid id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task<List<Car>> GetCars()
        {
            return await _context.Cars.OrderBy(c => c.Name).ToListAsync();
        }

        public bool UpdateCar(Guid id, CarViewModel viewModel)
        {
            Car car = _context.Cars.Find(id);

            if (car != null)
            {
                car.Name = viewModel.Name;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Color>> GetColors()
        {
            return await _context.Colors.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Color> GetColorById(Guid id)
        {
            return await _context.Colors.FindAsync(id);
        }

        public void AddColor(AdminColorViewModel viewModel)
        {
            Color color = new Color()
            {
                Id = CodeGenerators.GetId(),
                Code = viewModel.Code,
                Name = viewModel.Name
            };

            _context.Colors.Add(color);
            _context.SaveChanges();
        }

        public bool UpdateColor(AdminColorViewModel viewModel, Guid id)
        {
            Color color = _context.Colors.Find(id);

            if (color != null)
            {
                color.Name = viewModel.Name;
                color.Code = viewModel.Code;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteColor(Guid id)
        {
            Color color = _context.Colors.Find(id);

            if (color != null)
            {
                _context.Colors.Remove(color);
                _context.SaveChanges();

                
            }
        }

        public async Task<List<RateType>> GetRateTypes()
        {
            return await _context.RateTypes.OrderBy(r => r.Name).ToListAsync();
        }

        public async Task<RateType> GetRateTypeById(Guid id)
        {
            return await _context.RateTypes.FindAsync(id);
        }

        public void AddRateType(RateTypeViewModel viewModel)
        {
            RateType rateType = new RateType()
            {
                Id = CodeGenerators.GetId(),
                Name = viewModel.Name,
                OK = viewModel.OK,
                ViewOrder = viewModel.ViewOrder
            };

            _context.RateTypes.Add(rateType);
            _context.SaveChanges();
        }

        public bool UpdateRateType(RateTypeViewModel viewModel, Guid id)
        {
            RateType rateType = _context.RateTypes.Find(id);

            if (rateType != null)
            {
                rateType.Name = viewModel.Name;
                rateType.OK = viewModel.OK;
                rateType.ViewOrder = viewModel.ViewOrder;

                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public void DeleteRateType(Guid id)
        {
            RateType rateType = _context.RateTypes.Find(id);

            if (rateType != null)
            {
                _context.RateTypes.Remove(rateType);
                _context.SaveChanges();

            }

        }

        public async Task<Setting> GetSetting()
        {
            return await _context.Settings.FirstOrDefaultAsync();
        }

        public bool UpdateSiteSetting(SiteSettingViewModel viewModel)
        {
            Setting setting = _context.Settings.FirstOrDefault();

            if (setting != null)
            {
                setting.Desc = viewModel.Desc;
                setting.Tel = viewModel.Tel;
                setting.Name = viewModel.Name;
                setting.Fax = viewModel.Fax;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePriceSetting(PriceSettingViewModel viewModel)
        {
            Setting setting = _context.Settings.FirstOrDefault();

            if (setting != null)
            {
                setting.IsDistance = viewModel.IsDistance;
                setting.IsWeatherPirce = viewModel.IsWeatherPirce;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }


        public bool UpdateAboutSetting(AboutSettingViewModel viewModel)
        {
            Setting setting = _context.Settings.FirstOrDefault();

            if (setting != null)
            {
                setting.About = viewModel.About;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateTermsSetting(TermsSettingViewModel viewModel)
        {
            Setting setting = _context.Settings.FirstOrDefault();

            if (setting != null)
            {
                setting.Terms = viewModel.Terms;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<PriceType>> GetPriceTypes()
        {
            return await _context.priceTypes.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<PriceType> GetPriceTypeById(Guid id)
        {
            return await _context.priceTypes.FindAsync(id);
        }

        public void AddPriceType(PriceTypeViewModel viewModel)
        {
            PriceType priceType = new PriceType()
            {
                End = viewModel.End,
                Name = viewModel.Name,
                Price = viewModel.Price,
                Id = CodeGenerators.GetId(),
                Start = viewModel.Start
            };

            _context.priceTypes.Add(priceType);
            _context.SaveChanges();
        }

        public bool UpdatePriceType(PriceTypeViewModel viewModel, Guid id)
        {
            PriceType priceType = _context.priceTypes.Find(id);

            if (priceType != null)
            {
                priceType.End = viewModel.End;
                priceType.Start = viewModel.Start;
                priceType.Name = viewModel.Name;
                priceType.Price = viewModel.Price;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeletePriceType(Guid id)
        {
            PriceType priceType = _context.priceTypes.Find(id);

            _context.priceTypes.Remove(priceType);
            _context.SaveChanges();
        }

        public async Task<List<MonthType>> GetMonthTypes()
        {
            return await _context.MonthTypes.OrderBy(m => m.Name).ToListAsync();
        }

        public async Task<MonthType> GetMonthTypeById(Guid id)
        {
            return await _context.MonthTypes.FindAsync(id);
        }

        public void AddMonthType(MonthTypeViewModel viewModel)
        {
            MonthType monthType = new MonthType()
            {
                Id = CodeGenerators.GetId(),
                End = viewModel.End,
                Name = viewModel.Name,
                Precent = viewModel.Percent,
                Start = viewModel.Start
            };

            _context.MonthTypes.Add(monthType);
            _context.SaveChanges();
        }

        public bool UpdateMonthType(MonthTypeViewModel viewModel, Guid id)
        {
            MonthType monthType = _context.MonthTypes.Find(id);

            if (monthType != null)
            {
                monthType.End = viewModel.End;
                monthType.Start = viewModel.Start;
                monthType.Name = viewModel.Name;
                monthType.Precent = viewModel.Percent;

                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public void DeleteMonthType(Guid id)
        {
            MonthType monthType = _context.MonthTypes.Find(id);

            _context.MonthTypes.Remove(monthType);
            _context.SaveChanges();
        }
    }
}

