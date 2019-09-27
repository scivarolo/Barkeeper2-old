module.exports = {
  "parser": "@typescript-eslint/parser",
  "extends": [
    // "airbnb-typescript",
    // "airbnb/hooks"
    "eslint:recommended",
    "plugin:react/recommended",
    "plugin:@typescript-eslint/eslint-recommended",
    "plugin:@typescript-eslint/recommended",
    "plugin:@typescript-eslint/recommended-requiring-type-checking"
  ],
  "parserOptions": {
    "ecmaVersion": 2018,
    "sourceType": "module",
    "project": ["./tsconfig.json"],
    "tsconfigRootDir": __dirname,
    "ecmaFeatures": {
      "jsx": true
    }
  },
  "plugins": ["react", "@typescript-eslint", "react-hooks"],
  "env": {
    "browser": true,
    "es6": true,
    "jest": true
  },
  "settings": {
    "react": { "version": "detect" },
    "import/extensions": [".js", ".jsx", ".ts", ".tsx"],
    "import/parsers": {
      "@typescript-eslint/parser": [".ts", ".tsx", ".js", ".jsx"]
    },
    "import/resolver": {
      "node": {
        "extensions": [".js", ".jsx", ".ts", ".tsx"]
      }
    }
  },
  "rules": {
    "eqeqeq": ["error", "smart"],
    "indent": ["error", 2],
    "react/jsx-indent": ["error", 2],

    "@typescript-eslint/explicit-function-return-type": "off",
    "react-hooks/rules-of-hooks": "error",
    "react-hooks/exhaustive-deps": "warn",
    "quotes": ["error", "double"]

  }
}