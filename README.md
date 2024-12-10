# CityInfo API
This project is an ASP.NET Core Web API that provides information about cities and their points of interest. It was created to explore and practice the fundamentals of ASP.NET Core Web API development.

## Features
- Retrieve city details with or without points of interest.
- Retrieve, add, update, and delete points of interest for a city.
- Supports pagination and search filters for city queries.

## Endpoints
### Cities
- GET `/api/cities`: Retrieves a paginated list of cities with optional filters for name and search query.
- GET `/api/cities/{id}`: Retrieves detailed information about a specific city, optionally including points of interest.

### Points of Interest
- GET `/api/cities/{cityId}/pointsofinterest`: Retrieves all points of interest for a specific city.
- GET `/api/cities/{cityId}/pointsofinterest/{pointOfInterestId}`: Retrieves a specific point of interest by ID.
- POST `/api/cities/{cityId}/pointsofinterest`: Adds a new point of interest to a city.
- PUT `/api/cities/{cityId}/pointsofinterest/{pointOfInterestId}`: Updates an existing point of interest.
- DELETE `/api/cities/{cityId}/pointsofinterest/{pointOfInterestId}`: Deletes a point of interest.

## Example Usage
Use an API client like [Postman](https://www.postman.com/) to interact with the endpoints.

## Version Information
This project was built with the .NET 8.0 framework.

## Course
This API is for learning purposes and was built from the course [ASP.NET Core Web API Fundamentals](https://app.pluralsight.com/library/courses/asp-dot-net-core-6-web-api-fundamentals/table-of-contents) by Kevin Dockx.

## Author
GitHub: [Franco Dipre](https://github.com/diprefranco/)

## License
This project is licensed under the [MIT LICENSE](LICENSE).
