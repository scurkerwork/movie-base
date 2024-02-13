using Api.Business.DTOs;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Mapping
{
    /// <summary>
    /// Configuration profile for AutoMapper mappings.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
        /// </summary>
        public AutoMapperProfile()
        {
            // CreateMap method is used to define mappings between types

            // Map from Movie entity to MovieDto
            CreateMap<Movie, MovieDto>()
                // Map the Actors property of Movie to the Actors property of MovieDto
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors))
                // Map the Ratings property of Movie to the MovieRatings property of MovieDto
                .ForMember(dest => dest.MovieRatings, opt => opt.MapFrom(src => src.Ratings));

            // Map from MovieDto to Movie entity
            CreateMap<MovieDto, Movie>()
                // Map the Actors property of MovieDto to the Actors property of Movie
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors))
                // Map the MovieRatings property of MovieDto to the Ratings property of Movie
                .ForMember(dest => dest.Ratings, opt => opt.MapFrom(src => src.MovieRatings));

            // Map from Actor entity to ActorDto
            CreateMap<Actor, ActorDto>();

            // Map from ActorDto entity to Actor Entity
            CreateMap<ActorDto, Actor>();

            // Map from MovieRating entity to MovieRatingDto
            CreateMap<MovieRating, MovieRatingDto>();

            // Map from CreateMovieDto to Movie entity
            CreateMap<CreateMovieDto, Movie>();
        }
    }
}
