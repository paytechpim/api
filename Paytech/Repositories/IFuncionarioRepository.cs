﻿using Paytech.Models;

namespace Paytech.Repositories
{
    public interface IFuncionarioRepository
    {
            bool Insert(Funcionario funcionario);

            Funcionario GetById(int id);

            List<Funcionario> GetByName(string name);

            List<Funcionario> GetAll();

            void Delete(int id);
        }
    }

