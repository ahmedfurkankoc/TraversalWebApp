﻿using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDal<T>
	{
		void Insert(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetList();
		T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
