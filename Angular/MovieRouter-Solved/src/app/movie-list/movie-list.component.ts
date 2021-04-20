import { Component, OnInit} from '@angular/core';
import { Movie } from '../Shared/Movie';
import { MOCK_MOVIES } from '../Shared/MockMovies';
import { MovieService } from '../movie.service';
import { Router, ActivatedRoute, Params } from '@angular/router';



@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {
  movies : Movie[];


  constructor(private movieService : MovieService, private route: ActivatedRoute, private router: Router) {}

  ngOnInit() { this.movies=this.movieService.getMovies();}

   public onSelect(movie : Movie){
    this.router.navigate(['/movie-detail', movie.Title]); 
  }

}
