var gulp = require('gulp');
var sass = require('gulp-sass');
var concat = require('gulp-concat');
var minify = require('gulp-minify-css');
var merge = require('merge-stream');

gulp.task('scss', function() {
    var watcher = gulp.watch(['./wwwroot/content/stylesheets/scss/**/*.scss', './wwwroot/content/stylesheets/css/**/*.css']);
    watcher.on('change', function() {
        var scssStream = gulp.src('./wwwroot/content/stylesheets/scss/**/*.scss')
            .pipe(sass())
            .pipe(concat('scss-files.scss'))
        ;
        
        var cssStream = gulp.src('./wwwroot/content/stylesheets/css/**/*.css')
            .pipe(concat('css-files.css'))
        ;
    
        var mergedStream = merge(scssStream, cssStream)
            .pipe(concat('/styles.css'))
            .pipe(minify())
            .pipe(gulp.dest('wwwroot/content/stylesheets'));
    
        return mergedStream;
    });
})

