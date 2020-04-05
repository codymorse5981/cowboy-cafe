/* Author: Cody Morse
 * Class: PaymentType.cs
 * Description: Handles PaymentType class
  */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Enumeration values for the two types of payment available to complete the transaction
    /// </summary>
    public enum PaymentType
    {
        Cash,
        Credit
    }
}
