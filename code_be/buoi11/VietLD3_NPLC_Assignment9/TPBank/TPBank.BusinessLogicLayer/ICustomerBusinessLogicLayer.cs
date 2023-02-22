using TPbank.Entities.DTO;
using TPbank.Entities.Entity;
using TPbank.Entities.ExtensionMethod;

namespace TPBank.BusinessLogicLayer
{
    public interface ICustomerBusinessLogicLayer
    {
        /// <summary>
		/// Returns all existing customers.
		/// </summary>
		/// <returns></returns>
		List<CustomerDTO> GetCustomers();

        /// <summary>
        ///  Add Customer
        /// </summary>
        void AddCustomer();

        /// <summary>
        /// UpdateCustomer by customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Delete Customer by user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool DeleteCustomer(string user);

        /// <summary>
        /// Check Usename and Password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUsenamePassword(string username, string password);

        /// <summary>
        /// Get CustomersBy Condition
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Response<Customer> GetCustomersByCondition(Func<Customer, bool> value);

        /// <summary>
        /// Check user name exist
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        Response<Customer> IsUserNameExist(string? username);
    }
}
