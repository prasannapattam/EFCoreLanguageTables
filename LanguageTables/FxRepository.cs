using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTables
{
    class FxRepository: IDisposable
    {
        DbContext dbContext;
        string culture;

        public FxRepository(string culture)
        {
            // creating the factory and then the context based on the language
            this.culture = culture;
            FxDbFactory<EmployeeModel, EmployeeLanguageModel> factory = new FxDbFactory<EmployeeModel, EmployeeLanguageModel>();
            dbContext = factory.CreateDbContext(culture);
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public async Task<EmployeeModel> GetEmployee()
        {
            if(culture == null) // don't include when culture is null
            {
                return await dbContext.Set<EmployeeModel>().Where(e => e.Id == 1).FirstAsync();

            }
            else
            {
                return await dbContext.Set<EmployeeModel>().Include(e => e.Language).Where(e => e.Id == 1).FirstAsync();
            }
        }

        public async Task SaveEmployee(EmployeeModel employee)
        {
            dbContext.Update(employee);
            await dbContext.SaveChangesAsync();
        }
    }
}
