﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ortak kullanılacak oldugum crud islemleri icin generic interface olusturuldu.

namespace DataLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Add(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetList();
		T GetById(int id);
	}
}
