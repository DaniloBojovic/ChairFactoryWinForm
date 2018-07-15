using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    public class UnitOfWork
    {
        private readonly AppDbContext _context;

        private ItemRepository _itemRepository;
        private MachineRepository _machineRepository;
        private WorkOperationRepository _workOperationRepository;
        private ProductionPlanRepository _productionPlanRepository;
        private OperationPlanRepository _operationPlanRepository;

        public ItemRepository Items => _itemRepository ?? (_itemRepository = new ItemRepository(_context));
        public MachineRepository Machines => _machineRepository ?? (_machineRepository = new MachineRepository(_context));
        public WorkOperationRepository WorkOperations => _workOperationRepository ?? (_workOperationRepository = new WorkOperationRepository(_context));
        public ProductionPlanRepository ProductionPlans =>_productionPlanRepository ?? (_productionPlanRepository = new ProductionPlanRepository(_context));
        public OperationPlanRepository OperationPlans => _operationPlanRepository ?? (_operationPlanRepository = new OperationPlanRepository(_context));



        public UnitOfWork()
        {
            _context = new AppDbContext();
        }


        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                ThrowEnhancedValidationException(e);
            }
        }

        protected virtual void ThrowEnhancedValidationException(DbEntityValidationException e)
        {
            var errorMessages = e.EntityValidationErrors
                .SelectMany(x => x.ValidationErrors)
                .Select(x => x.ErrorMessage);

            var fullErrorMessage = string.Join("; ", errorMessages);
            var exceptionMessage = string.Concat(e.Message, " The validation errors are: ", fullErrorMessage);
            throw new DbEntityValidationException(exceptionMessage, e.EntityValidationErrors);
        }
    }
}
