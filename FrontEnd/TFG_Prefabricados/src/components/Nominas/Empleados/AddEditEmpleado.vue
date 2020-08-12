<template>
    <div class="addEditEmpleado">
        <div class="row">
             <div class="col-sm-3" v-show="isEditMode">
                <v-text-field :disabled="isEditMode" label="Codigo" required v-model="value.codigo"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="Nombre*" required v-model="value.nombre"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="Apellidos" v-model="value.apellidos"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="NIF" persistent-hint required v-model="value.nif"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="Email*" required v-model="value.email"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="Poblacion*" required v-model="value.poblacion"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="Provincia*" required v-model="value.provincia"></v-text-field>
            </div>

            <div class="col-sm-3">
                <v-text-field label="Cod Postal" required v-model="value.codPostal"></v-text-field>               
            </div> 
            
            <div class="col-sm-3">
                <v-text-field label="Dirección" required v-model="value.direccion"></v-text-field>             
            </div> 

            <div class="col-sm-3">
                <v-text-field label="Teléfono" required v-model="value.telefono"></v-text-field>            
            </div> 

            <div class="col-sm-3">
                <v-text-field label="IBAN" required v-model="value.iban"></v-text-field>
            </div>        
        </div> 
    </div>  
</template>

<script>
    export default {
        name: 'addEditEmpleado',
        
        data() {
            return {};
        }, 
        
        props: {
            value: {
                type: Object, 
                required: true, 
                default: () => {}
            },
            isEditMode: {
                type: Boolean, 
                required: true,
                default: false
            }
        },
        
        computed: { },

        created () { },   
    
        methods: { 
            
        },
    };
</script>