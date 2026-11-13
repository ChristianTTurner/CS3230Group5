
using System;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.Controller
{
    /// <summary>
    /// Handles loading and updating nurse information.
    /// Provides access to nurse records and their associated addresses and passwords.
    /// </summary>
    public class UpdateNurseController
    {
        private readonly NurseDal _nurseDal;

        /// <summary>
        /// Initializes a new instance of the UpdateNurseController class.
        /// Creates a NurseDal instance for accessing nurse data.
        /// </summary>
        public UpdateNurseController()
        {
            _nurseDal = new NurseDal();
        }

        /// <summary>
        /// Retrieves a nurse and the associated address using the nurse ID.
        /// </summary>
        /// <param name="nurseId">The unique identifier of the nurse.</param>
        /// <returns>
        /// A tuple containing the nurse and address if found; otherwise, null.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the nurse ID is less than or equal to zero.
        /// </exception>
        public (Nurse Nurse, Address Address)? Load(int nurseId)
        {
            if (nurseId <= 0) throw new ArgumentOutOfRangeException(nameof(nurseId));
            return _nurseDal.GetNurseById(nurseId);
        }

        /// <summary>
        /// Updates an existing nurse's information, address, and password.
        /// </summary>
        /// <param name="nurse">The nurse object containing the updated information.</param>
        /// <param name="address">The address object containing the updated address information.</param>
        /// <param name="password">The nurse's updated password.</param>
        /// <returns>
        /// True if the nurse information is successfully updated; otherwise, false.
        /// </returns>
        public bool Update(Nurse nurse, Address address, string password)
        {
            return _nurseDal.UpdateNurse(nurse, address, password);
        }

        /// <summary>
        /// Retrieves the stored password for a nurse using the nurse ID.
        /// </summary>
        /// <param name="nurseId">The unique identifier of the nurse.</param>
        /// <returns>The nurse's stored password, or null if the nurse is not found.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the nurse ID is less than or equal to zero.
        /// </exception>
        public string? LoadPassword(int nurseId)
        {
            if (nurseId <= 0)
                throw new ArgumentOutOfRangeException(nameof(nurseId));

            return _nurseDal.GetNursePasswordById(nurseId);
        }
    }
}
