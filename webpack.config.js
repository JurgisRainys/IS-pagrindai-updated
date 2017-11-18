const path = require('path');
const bundleOutputDir = './wwwroot/dist';
const HtmlWebpackPlugin = require('html-webpack-plugin')

module.exports = {
    entry: {
        main: path.resolve(__dirname, 'Scripts/App.jsx')
    },
    output: {
        path: path.join(__dirname, bundleOutputDir),
        filename: 'main.js',
        publicPath: '/dist/'
    },

    module: {
        rules: [
            {
                test: /\.jsx$/,
                exclude: /node_modules/,
                loader: 'babel-loader',
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    plugins: [
        new HtmlWebpackPlugin({
            template: path.resolve(__dirname, 'wwwroot/index.html')
        })
    ],

    devServer: {
        inline: true,
        contentBase: 'wwwroot'
    }
};