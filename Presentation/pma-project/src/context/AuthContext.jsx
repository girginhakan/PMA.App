import React, { createContext, useState } from 'react'

const AuthContext = createContext();
export const AuthProvider=({children})=>{
    const [isAuthenticated,setIsAuthenticated]=useState(false);

    const login= async (username,password)=>{
        try {
            const response=await AuthService.login(username,password);
            if (condition) {
                
            }
        } catch (error) {
            
        }
    }
}

 

export default AuthContext