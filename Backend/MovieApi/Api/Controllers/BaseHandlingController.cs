using Api.Business.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    /// <summary>
    /// Base controller for handling common functionality across controllers.
    /// </summary>
    public class BaseHandlingController : ControllerBase
    {
        /// <summary>
        /// Gets the result object based on the caught exception.
        /// </summary>
        /// <param name="ex">The caught exception.</param>
        /// <returns>A result object including the status code.</returns>
        protected ObjectResult GetResultByException(Exception ex)
        {
            // Determine the status code based on the exception type
            int statusCode;
            if (ex is UnauthorizedAccessException)
            {
                statusCode = StatusCodes.Status401Unauthorized;
            }
            else
            {
                statusCode = StatusCodes.Status400BadRequest;
            }

            // Create an ApiResponse object with the appropriate status code and error message
            ApiResponse<object> response = new ApiResponse<object>
            {
                StatusCode = statusCode,
                ErrorMessage = ex.Message
            };

            // Return the response with the corresponding status code
            return StatusCode(statusCode, response);
        }

        /// <summary>
        /// Handles validation errors and returns an appropriate response.
        /// </summary>
        /// <typeparam name="T">The type of data in the response.</typeparam>
        /// <returns>An action result representing the validation errors, or null if no errors are found.</returns>
        protected ActionResult<ApiResponse<T>> HandleValidationErrors<T>()
        {
            // Create a new ApiResponse object
            ApiResponse<T> response = new ApiResponse<T>();

            // Check if there are any validation errors in the model state
            if (!ModelState.IsValid)
            {
                // Extract the error messages from the model state
                List<string> errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();

                // Populate the ApiResponse object with the error details
                response.Success = false;
                response.ErrorMessage = "Validation failed.";
                response.Errors = errors;
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Data = default(T);

                // Return a BadRequest response with the ApiResponse object
                return BadRequest(response);
            }

            // If no validation errors are found, return null
            return null;
        }
    }
}
