using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageTables
{
    class FxDbFactory<TEntity, TLanguageEntity>
        where TEntity: class
    {
        // this is used to map the culture with dummy classes
        private static Dictionary<string, int> Mappping = new Dictionary<string, int>();

        public FxDbContext<TEntity> CreateDbContext(string culture)
        {
            // we created then dummy classes. Dynamically assigning these dummy classes
            // to a culture. Based on values of culture these classes will be assigned
            // for example, if this method first called with "en" then Dummy class 1 will be en
            // next if called with "te" then Dummy class 2 will be te 
            // if again called with "en" then previously assigned Dummy Class 1 will be used
            int languageOption;
            if(culture == null)
            {
                languageOption = 0;
            }
            else if (Mappping.ContainsKey(culture))
            {
                languageOption = Mappping[culture];
            }
            else
            {
                languageOption = Mappping.Count + 1;
                Mappping.Add(culture, languageOption);
            }

            switch (languageOption)
            {
                case 0:
                    return new FxDbContext<TEntity>();  // no language option
                case 1:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity1>(culture);
                case 2:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity2>(culture);
                case 3:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity3>(culture);
                case 4:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity4>(culture);
                case 5:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity5>(culture);
                case 6:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity6>(culture);
                case 7:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity7>(culture);
                case 8:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity8>(culture);
                case 9:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity9>(culture);
                case 10:
                    return new FxLanguageDbContext<TEntity, FxLanguageEntity10>(culture);
                default:
                    return new FxDbContext<TEntity>();
            }
        }
    }
}
