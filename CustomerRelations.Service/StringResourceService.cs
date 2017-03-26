using CustomerRelations.Data.Infrastructure;
using CustomerRelations.Data.Repositories;
using CustomerRelations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelations.Service
{
    public interface IStringResourceService
    {
        IEnumerable<StringResource> GetStringResources();
        IEnumerable<StringResource> GetCultureStringResources(string cultureCode);
        StringResource GetStringResource(string cultureCode, string resourceKey);
        void CreateStringResource(StringResource stringResource);
        void SaveStringResource();
    }

    public class StringResourceService : IStringResourceService
    {
        private readonly IStringResourceRepository stringResourcesRepository;
        private readonly IUnitOfWork unitOfWork;

        public StringResourceService(IStringResourceRepository stringResourcesRepository, IUnitOfWork unitOfWork)
        {
            this.stringResourcesRepository = stringResourcesRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<StringResource> GetStringResources()
        {
            var stringResources = stringResourcesRepository.GetAll();
            return stringResources;
        }

        public IEnumerable<StringResource> GetCultureStringResources(string cultureCode)
        {
            return stringResourcesRepository.GetCultureStringResources(cultureCode);
        }

        public StringResource GetStringResource(string cultureCode, string resourceKey)
        {
            var stringResource = stringResourcesRepository.Get(x => x.cultureCode == cultureCode && x.resourceKey == resourceKey);
            return stringResource;
        }

        public void CreateStringResource(StringResource stringResource)
        {
            stringResourcesRepository.Add(stringResource);
            this.SaveStringResource();
        }

        public void SaveStringResource()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
