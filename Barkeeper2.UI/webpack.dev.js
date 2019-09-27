var webpack = require("webpack");
var path = require("path");
var WebpackNotifier = require("webpack-notifier");

module.exports = {
  mode: "development",
  entry: "./src/index.tsx",
  module: {
    rules: [
      {
        test: /\.ts(x?)$/,
        use: "ts-loader",
        exclude: /node_modules/
      },
      {
        test: /\.js(x?)$/,
        use: "ts-loader",
        exclude: /node_modules/
      },
      {
        test: /\.css$/i,
        use: ["style-loader", "css-loader"]
      },
      {
        enforce: "pre",
        test: /\.js$/,
        loader: "source-map-loader"
      }
    ]
  },
  resolve: {
    extensions: [".tsx", ".ts", ".jsx", ".js", ".css"],
    alias: {},
  },
  output: {
    filename: "react.bundle.js",
    path: path.resolve(__dirname, "public/")
  },
  devtool: "source-map",
  devServer: {
    contentBase: "./public"
  },
  plugins: [
    new WebpackNotifier(),
    new webpack.DefinePlugin({
      "process.env.API_URL": JSON.stringify("https://localhost:44329")
    })
  ],
  externals: {
    // "react": "React",
    // "react-dom": "ReactDOM"
  }
}