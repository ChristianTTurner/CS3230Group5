using System;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.Controller
{
    /// <summary>
    /// Controller for updating an existing nurse. Wraps NurseDal and exposes simple load/update operations.
    /// </summary>
    public class UpdateNurseController
    {
        private readonly NurseDal _nurseDal;

        public UpdateNurseController()
        {
            _nurseDal = new NurseDal();
        }

        public (Nurse Nurse, Address Address)? Load(int nurseId)
        {
            if (nurseId <= 0) throw new ArgumentOutOfRangeException(nameof(nurseId));
            return _nurseDal.GetNurseById(nurseId);
        }

        public bool Update(Nurse nurse, Address address)
        {
            return _nurseDal.UpdateNurse(nurse, address);
        }
    }
}
