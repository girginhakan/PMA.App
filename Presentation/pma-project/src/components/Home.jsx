import React from 'react'
import Navi from './Navi'
import { Outlet } from 'react-router-dom'
import PlantList from './PlantList'
import Footer from './Footer'

const Home = () => {
  return (
    <>
    <Navi/>
    <Outlet/>
    <PlantList/>
    <Footer/>
    </>
  )
}

export default Home