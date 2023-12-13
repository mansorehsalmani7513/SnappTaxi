using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Snapp.Core.ViewModels.Admin;

using Snapp.DataAccessLayer.Entites;

namespace Snapp.Core.Interfaces
{
    public interface IAdmin : IDisposable
    {
        #region Car

        Task<List<Car>> GetCars();

        Task<Car> GetCarById(Guid id);

        void AddCar(CarViewModel viewModel);

        bool UpdateCar(Guid id, CarViewModel viewModel);

        void DeleteCar(Guid id);

        #endregion

        #region Color

        Task<List<Color>> GetColors();

        Task<Color> GetColorById(Guid id);

        void AddColor(AdminColorViewModel viewModel);

        bool UpdateColor(AdminColorViewModel viewModel, Guid id);

        void DeleteColor(Guid id);

        #endregion

        #region RateType

        Task<List<RateType>> GetRateTypes();

        Task<RateType> GetRateTypeById(Guid id);

        void AddRateType(RateTypeViewModel viewModel);

        bool UpdateRateType(RateTypeViewModel viewModel, Guid id);

        void DeleteRateType(Guid id);

        #endregion

        #region Setting

        Task<Setting> GetSetting();

        bool UpdateSiteSetting(SiteSettingViewModel viewModel);

        bool UpdatePriceSetting(PriceSettingViewModel viewModel);

        bool UpdateAboutSetting(AboutSettingViewModel viewModel);

        bool UpdateTermsSetting(TermsSettingViewModel viewModel);



        #endregion

        #region PriceType

        Task<List<PriceType>> GetPriceTypes();

        Task<PriceType> GetPriceTypeById(Guid id);

        void AddPriceType(PriceTypeViewModel viewModel);

        bool UpdatePriceType(PriceTypeViewModel viewModel, Guid id);

        void DeletePriceType(Guid id);

        #endregion

        #region MonthType

        Task<List<MonthType>> GetMonthTypes();

        Task<MonthType> GetMonthTypeById(Guid id);

        void AddMonthType(MonthTypeViewModel viewModel);

        bool UpdateMonthType(MonthTypeViewModel viewModel, Guid id);

        void DeleteMonthType(Guid id);

        #endregion
    }
}
