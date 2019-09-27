import React from "react";
import { Switch, Route } from "react-router-dom";
import AuthorizeRoute from "./components/api-authorization/AuthorizeRoute";
import ApiAuthorizationRoutes from "./components/api-authorization/ApiAuthorizationRoutes";
import { ApplicationPaths } from "./components/api-authorization/ApiAuthorizationConstants";
import Home from "./components/Home";
import { Layout } from "./components/Layout";

const App = () => {
  return (
    <div>
      <Layout>
        <Switch>
          <Route exact path="/" component={Home} />
        </Switch>
      </Layout>
    </div>
  );
};

export default App;