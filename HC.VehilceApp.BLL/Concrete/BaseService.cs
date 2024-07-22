using AutoMapper;
using HC.VehicleApp.Entities.Abstract;
using HC.VehilceApp.BLL.Abstract;
using HC.VehilceApp.BLL.Utilities.Results;
using HC.VehilceApp.DAL.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HC.VehilceApp.BLL.Concrete
{
    public class BaseService<T, TDto, TCreateDto, TUpdateDto, TListDto> : IService<T, TDto, TCreateDto, TUpdateDto, TListDto> where T : class, IEntity
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
        where TListDto : class
    {
        private readonly IMapper _mapper;
        protected readonly IUow _uow;
        public BaseService(IMapper mapper, IUow uow)
        {
            _mapper = mapper;
            _uow = uow;
        }
        /// <summary>
        /// Bir veri siler.
        /// </summary>
        /// <param name="id">Silinecek veri kimliği.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _uow.GetRepository<T>().DeleteAsync(id);
            await _uow.SaveChangesAsync();
            return new SuccessResult("Deletion successful.");
        }
        /// <summary>
        /// Tüm veri kayıtlarını getirir.
        /// </summary>
        /// <param name="asNoTracking">Verinin izlenmemesi durumunu belirler. Varsayılan true olarak ayarlanmıştır.</param>
        /// <param name="filter">Veriyi filtrelemek için kullanılacak ifade. Varsayılan null olarak ayarlanmıştır.</param>
        /// <param name="includeProperties">İlişkili veri tablolarını dahil etmek için kullanılacak ifade listesi.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse tüm verileri içeren bir listeyi içeren bir sonuç nesnesi döndürür.</returns>
        public async Task<IResult> GetAllAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            var entities = await _uow.GetRepository<T>().GetAllAsync();
            if (entities.Count()<=0) { return new ErrorResult("There are no values to list"); }
            var dtos = _mapper.Map<List<TListDto>>(entities);
            return new SuccessDataResult<List<TListDto>>(dtos, "Listing successful");
        }
        /// <summary>
        /// Belirtilen filtre kriterlerine göre veri kaydını getirir.
        /// </summary>
        /// <param name="asNoTracking">Verinin izlenmemesi durumunu belirler. Varsayılan olarak true  ayarlanmıştır.</param>
        /// <param name="filter">Veriyi filtrelemek için kullanılacak ifade. Varsayılan olarak null  ayarlanmıştır.</param>
        /// <param name="includeProperties">İlişkili veri tablolarını dahil etmek için kullanılacak ifade listesi.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        public async Task<IResult> GetAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            var entity = await _uow.GetRepository<T>().GetAsync(asNoTracking, filter, includeProperties);
            if (entity == null) { return new ErrorResult("Value not found"); }
            var dto = _mapper.Map<TListDto>(entity);
            return new SuccessDataResult<TListDto>(dto, "Acquirement successful.");
        }
        /// <summary>
        /// YBelirtilen verinin detaylarını getirir.
        /// </summary>
        /// <param name="id">Detay alınacak veri kimliği.</param>
        /// <param name="tracking">Veri izleme durumunu belirtir. Varsayılan olarak true  ayarlanmıştır.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        public async Task<IResult> GetByIdAsync(Guid id, bool tracking = true)
        {
            var entity = await _uow.GetRepository<T>().GetByIdAsync(id, tracking);
            if (entity == null) { return new ErrorResult("Value not found"); }
            var dto = _mapper.Map<TListDto>(entity);
            return new SuccessDataResult<TListDto>(dto, "Acquirement successful");
        }
        /// <summary>
        /// Yeni bir veri ekler.
        /// </summary>
        /// <param name="dto">Eklenecek veri.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        public async Task<IResult> InsertAsync(TCreateDto dto)
        {
            var newEntity = _mapper.Map<T>(dto);
            await _uow.GetRepository<T>().InsertAsync(newEntity);
            await _uow.SaveChangesAsync();
            return new SuccessResult("Insertion successful");
        }
        /// <summary>
        /// Veriyi günceller.
        /// </summary>
        /// <param name="dto">Güncellenecek verileri içeren dto.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        public async Task<IResult> UpdateAsync(TUpdateDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            await _uow.GetRepository<T>().UpdateAsync(entity);
            await _uow.SaveChangesAsync();
            return new SuccessResult("Updating successful");
        }
    }
}
