using System;
using System.Text.RegularExpressions;

namespace HipChat.Net.Helpers
{
  internal static class Validate
  {
    /// <summary>
    /// Nots the null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="name">The name.</param>
    /// <exception cref="System.ArgumentException"></exception>
    public static void NotNull(object value, string name)
    {
      if (value != null)
        return;

      throw new ArgumentException(string.Format("{0} cannot be null", name));
    }

    /// <summary>
    /// Nots the empty.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="name">The name.</param>
    /// <exception cref="System.ArgumentException"></exception>
    public static void NotEmpty(string value, string name)
    {
      if (!string.IsNullOrEmpty(value))
        return;

      throw new ArgumentException(string.Format("{0} cannot be null or empty", name));
    }

    /// <summary>
    /// Lengthes the specified value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="length">The length.</param>
    /// <param name="name">The name.</param>
    /// <exception cref="System.ArgumentException"></exception>
    public static void Length(string value, int length, string name)
    {
      NotEmpty(value, name);

      if (value.Length <= length)
        return;

      throw new ArgumentException(string.Format("{0} must have a length less than or equal to {1}", name, length));
    }

    /// <summary>
    /// Mentions the specified value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="name">The name.</param>
    /// <exception cref="System.ArgumentException"></exception>
    public static void Mention(string value, string name)
    {
      NotEmpty(value, name);

      if (value.StartsWith("@") && !Regex.IsMatch(value, @"\s+"))
        return;

      throw new ArgumentException(string.Format("{0} must begin with @ and contain no spaces", name));
    }
  }
}
