using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IGuideDal : IGenericDal<Guide>
	{
		void ChangeToStatusActive(int id);
		void ChangeToStatusPassive(int id);
	}
}
