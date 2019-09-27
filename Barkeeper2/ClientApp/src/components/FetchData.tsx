import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

interface Forecast {
  dateFormatted: string,
  temperatureC: string,
  temperatureF: string,
  summary: string
}
interface FetchDataState {
  forecasts: Array<Forecast>,
  loading?: boolean,
  ingredients?: Array<any>
}


export class FetchData extends Component<{}, FetchDataState> {
  static displayName = FetchData.name;

  constructor(props: any) {
    super(props);
    this.state = { forecasts: [], loading: true }
  }

  componentDidMount() {
      this.populateWeatherData();
      this.getIngredients();
  }

  static renderForecastsTable(forecasts: Array<Forecast>) {
    return (
      <table className='table table-striped'>
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.dateFormatted}>
              <td>{forecast.dateFormatted}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.forecasts);
      let ingredients = this.state.ingredients
          ? <p>{this.state.ingredients[0].name}</p>
          : "No Ingredients";

      return (
          <>
              <div>
                    <h1>Weather forecast</h1>
                    <p>This component demonstrates fetching data from the server.</p>
                    {contents}
              </div>
              <div>
                  {ingredients}
                  </div>
              </>
    );
  }

  async populateWeatherData() {
    const token = await authService.getAccessToken();
    const response = await fetch('api/SampleData/WeatherForecasts', {
      headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
    });
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
    }

    async getIngredients() {
        const token = await authService.getAccessToken();
        const response = await fetch('api/v2/ingredients', {
            headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
        });
        const data = await response.json();
        this.setState({ ingredients: data, loading: false });
    }

}
