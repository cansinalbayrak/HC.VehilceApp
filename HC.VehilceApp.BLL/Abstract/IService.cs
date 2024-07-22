using HC.VehicleApp.Entities.Abstract;
using HC.VehilceApp.BLL.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Abstract
{
    public interface IService<T, TDto, TCreateDto, TUpdateDto, TListDto> where T : class, IEntity 
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
        where TListDto : class
    {
        /// <summary>
        /// Yeni bir veri ekler.
        /// </summary>
        /// <param name="dto">Eklenecek veri.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> InsertAsync(TCreateDto dto);
        /// <summary>
        /// Veriyi günceller.
        /// </summary>
        /// <param name="dto">Güncellenecek verileri içeren dto.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> UpdateAsync(TUpdateDto dto);
        /// <summary>
        /// Bir veri siler.
        /// </summary>
        /// <param name="id">Silinecek veri kimliği.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> DeleteAsync(Guid id);
        /// <summary>
        /// YBelirtilen verinin detaylarını getirir.
        /// </summary>
        /// <param name="id">Detay alınacak veri kimliği.</param>
        /// <param name="tracking">Veri izleme durumunu belirtir. Varsayılan olarak true  ayarlanmıştır.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> GetByIdAsync(Guid id, bool tracking = true);
        /// <summary>
        /// Belirtilen filtre kriterlerine göre veri kaydını getirir.
        /// </summary>
        /// <param name="asNoTracking">Verinin izlenmemesi durumunu belirler. Varsayılan olarak true  ayarlanmıştır.</param>
        /// <param name="filter">Veriyi filtrelemek için kullanılacak ifade. Varsayılan olarak null  ayarlanmıştır.</param>
        /// <param name="includeProperties">İlişkili veri tablolarını dahil etmek için kullanılacak ifade listesi.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse verileri içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> GetAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Tüm veri kayıtlarını getirir.
        /// </summary>
        /// <param name="asNoTracking">Verinin izlenmemesi durumunu belirler. Varsayılan true olarak ayarlanmıştır.</param>
        /// <param name="filter">Veriyi filtrelemek için kullanılacak ifade. Varsayılan null olarak ayarlanmıştır.</param>
        /// <param name="includeProperties">İlişkili veri tablolarını dahil etmek için kullanılacak ifade listesi.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse tüm verileri içeren bir listeyi içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> GetAllAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties);
    }
}
