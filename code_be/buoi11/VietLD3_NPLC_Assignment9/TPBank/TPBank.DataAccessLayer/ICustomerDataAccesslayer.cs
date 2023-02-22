using TPbank.Entities.ExtensionMethod;

namespace TPBank.DataAccessLayer
{
    public interface ICustomerDataAccesslayer
    {
        /// <summary>
        /// Returns all existing customers.
        /// </summary>
        /// <returns></returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Returns a set of customers that matches with specified criteria.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate);

        /// <summary>
        /// Adds a new customer to the existing customers list.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes an existing customer.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool DeleteCustomer(String name);
    }
}
